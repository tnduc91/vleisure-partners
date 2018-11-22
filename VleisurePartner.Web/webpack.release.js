var webpackbase = require("./webpack.config");
var webpack = require("webpack");
var merge = require('webpack-merge');
var CleanWebpackPlugin = require('clean-webpack-plugin');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');

module.exports = merge(webpackbase, {
    devtool: false,
    output: {
        filename: "[name].[chunkhash].js",
        chunkFilename: "bundle.[name].[chunkhash].js"
    }
});

// http://vue-loader.vuejs.org/en/workflow/production.html
module.exports.plugins = (module.exports.plugins || []).concat([
    new CleanWebpackPlugin(['dist']),
    new webpack.DefinePlugin({
        'process.env': {
            NODE_ENV: '"production"'
        }
    }),
    new UglifyJsPlugin({
        sourceMap: false,
        uglifyOptions: {
            compress: {
                warnings: false
            },
            output: { comments: false }
        }
    }),
    new webpack.LoaderOptionsPlugin({
        minimize: true
    })
]);