var path = require("path");
var webpack = require("webpack");
var WebpackNotifierPlugin = require("webpack-notifier");
var ExtractTextPlugin = require("extract-text-webpack-plugin");
var autoprefixer = require("autoprefixer");
var precss = require("precss");
var ManifestPlugin = require("webpack-manifest-plugin");
var HardSourceWebpackPlugin = require("hard-source-webpack-plugin");
var HappyPack = require("happypack");
var CopyWebpackPlugin = require('copy-webpack-plugin');
var ForkTsCheckerNotifierWebpackPlugin = require('fork-ts-checker-notifier-webpack-plugin');
var ForkTsCheckerWebpackPlugin = require('fork-ts-checker-webpack-plugin');
var BundleAnalyzerPlugin = require('webpack-bundle-analyzer').BundleAnalyzerPlugin;

var loadersForTs = [
    {
        loader: "ts-loader",
        options: {
            appendTsxSuffixTo: [/\.vue$/],
            happyPackMode: true
        }
    }
];

module.exports = {
    devtool: true,
    entry: {
        "main": "./src/main.ts"
        // "error": "./src/error.ts"
    },
    output: {
        path: path.resolve(__dirname, "./dist"),
        publicPath:  "/dist/",
        filename: '[name].js',
        chunkFilename: 'bundle.[name].js',
        devtoolModuleFilenameTemplate: info => {
            if (info.resource.match(/\.vue$/)) {
                $filename = info.allLoaders.match(/type=script/)
                    ? info.resourcePath : 'generated';
            } else {
                $filename = info.resourcePath;
            }
            return $filename;
        }
    },
    module: {
        rules: [
            {
                test: /\.ts$/,
                exclude: /node_modules/,
                loader: "happypack/loader?id=1"
            },
            {
                test: /\.vue$/,
                loader: "vue-loader",
                options: {
                    esModule: true,
                    loaders: {
                        'scss': "vue-style-loader!css-loader!sass-loader",
                        'sass': "vue-style-loader!css-loader!sass-loader?indentedSyntax",
                        'ts': "happypack/loader?id=1",
                        'css': "vue-style-loader!css-loader"
                    }
                }
            },
            {
                test: /\.(png|jpg|gif|svg)$/,
                loader: "file-loader",
                options: {
                    name: "[name].[ext]?[hash]"
                }
            },
            {
                test: require.resolve("jquery"), loader: "expose-loader?$!expose-loader?jQuery"
            },
            {
                test: /\.css$/, use: ["style-loader", "css-loader", "postcss-loader"]
            },
            {
                test: /\.scss$/,
                use: [
                    {
                        loader: "style-loader" // creates style nodes from JS strings
                    },
                    {
                        loader: "css-loader" // translates CSS into CommonJS
                    },
                    {
                        loader: "postcss-loader", // Run post css actions
                        options: {
                            plugins() {
                                // post css plugins, can be exported to postcss.config.js
                                return [
                                    precss,
                                    autoprefixer
                                ];
                            }
                        }
                    },
                    {
                        loader: "sass-loader" // compiles Sass to CSS
                    }
                ]
            },
            {
                test: /.(ttf|otf|eot|svg|woff(2)?)(\?[a-z0-9]+)?$/,
                use: [{
                    loader: "file-loader",
                    options: {
                        name: "[name].[ext]",
                        outputPath: "fonts/",    // where the fonts will go
                        publicPath: "/dist/"       // override the default path
                    }
                }]
            },
            {
                test: /bootstrap\/dist\/js\/umd\//, use: 'imports-loader?jQuery=jquery'
            }
        ]
    },
    resolve: {
        extensions: [".ts", ".js", ".vue"],
        alias: {
            'vue$': "vue/dist/vue.esm.js",
            '@src': path.resolve( __dirname, "src" ),
            '@assets': path.resolve( __dirname, "assets" ),
            '@app': path.resolve( __dirname, "src/app" ),
            '@components': path.resolve( __dirname, "src/app/shared/components"),
            '@infrastructure': path.resolve( __dirname, "src/infrastructure" ),
            '@proxy': path.resolve( __dirname, "src/proxy" )
        }
    },
    performance: {
        hints: false
    },
    devtool: "hidden-source-map",
    plugins: [
        new ForkTsCheckerWebpackPlugin({
            vue: true,
            checkSyntacticErrors: true,
            tslint: true
        }),
        new ForkTsCheckerNotifierWebpackPlugin({ excludeWarnings: true }),
        new ExtractTextPlugin("style.css"),
        new webpack.ContextReplacementPlugin(/moment[\/\\]locale$/, /en-au/), //only load moment/locale/en-au
        new webpack.ProvidePlugin({
            $: "jquery",
            jQuery: "jquery",
            'window.jQuery': "jquery",
            Popper: ["popper.js", "default"],
            moment: "moment"
        }),
        new webpack.SourceMapDevToolPlugin({
            filename: "[name].js.map"
        }),
        new webpack.HashedModuleIdsPlugin(),
        new webpack.optimize.CommonsChunkPlugin({
            name: "vendor",
            minChunks: function (module) {
                // a module is extracted into the vendor chunk if...
                return (
                    // it's inside node_modules
                    /node_modules/.test(module.context) &&
                        // and not a CSS file (due to extract-text-webpack-plugin limitation)
                        !/\.css$/.test(module.request)
                );
            }
        }),
        //new webpack.optimize.CommonsChunkPlugin({
        //    names: ['vendor', 'manifest'],
        //    minChunks: 1
        //}),
        // extract webpack runtime & manifest to avoid vendor chunk hash changing
        // on every build.
        new webpack.optimize.CommonsChunkPlugin({
            name: "manifest"
        }),
        new ManifestPlugin(),
        new HappyPack({
            id: "1",
            loaders: loadersForTs,
            threads: 4
        }),
        new CopyWebpackPlugin([
            {
                from: '**/*',
                to: 'skins/',
                context: 'node_modules/tinymce/skins/'
            }
        ])
    ]
}


if (process.env.NODE_ENV === "development") {
    module.exports.profile = true;
    module.exports.plugins = (module.exports.plugins || []).concat([
        new WebpackNotifierPlugin(),
        new HardSourceWebpackPlugin()
    ]);
}

if (process.argv.findIndex(arg => {
        return arg === "--profile";
    })
    >= 0) {
    module.exports.plugins = (module.exports.plugins || []).concat([
        new BundleAnalyzerPlugin()
    ]);
}