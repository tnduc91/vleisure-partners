/* tslint:disable */

const Home: Function = () => import("@app/home/main.vue");

export enum WellKnownRouter {
    Default = "default",
    Home = "home"
}

export default {
    linkExactActiveClass: "active",
    linkActiveClass: "active",
    routes: [
        { name: WellKnownRouter.Default, path: "*", redirect: "/home" },
        /*Home Page*/
        {
            name: WellKnownRouter.Home,
            path: "/home",
            component: Home,
            meta: { icon: "fa fa-home", description: "Home" },
            children: [
                /*Error Page*/
                //{
                //    name: WellKnownRouter.Error,
                //    path: "error/:errorCode?/:errorMessage?",
                //    component: Error,
                //    meta: { icon: "fa fa-exclamation-triangle", description: "Error" },
                //    props: (route) =>
                //        ({
                //            errorCode: route.params.errorCode as number,
                //            errorMessage: route.params.errorMessage as string
                //        })
                //},
                /*Calendar Page*/
                //{
                //    name: WellKnownRouter.Calendar,
                //    path: "calendar",
                //    component: Calendar,
                //    meta: { icon: "fa fa-calendar", description: "Calendar" },
                //    redirect: "calendar/schedule",
                //    children: [
                //        {
                //            name: WellKnownRouter.Schedule,
                //            path: "schedule",
                //            component: Schedule,
                //            meta: { description: "Confirmed Schedule" }
                //        },
                //        {
                //            name: WellKnownRouter.Availability,
                //            path: "availability",
                //            component: ProviderAvailability,
                //            meta: { description: "Provide Availability" }
                //        }
                //    ]
                //}
            ]
        }
    ]
};
