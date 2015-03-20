angular.module("HaterDateApp", ["ngRoute"])

.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            controller: "ProfileController",
            templateUrl: "/templates/homeView.html"
        })
        .when("/Profile", {
            controller: "ProfileController",
            templateUrl: "/AngularApp/StaticViews/ProfileForm.html"
        })
        .when("/Profile/:id", {
            controller: "ProfileController",
            templateUrl: "/AngularApp/StaticViews/SOMETHING.html"
        })
        .otherwise({ redirectTo: "/" });
})