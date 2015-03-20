angular.module("HaterDateApp", ["ngRoute"])

.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            controller: "ProfileController",
            templateUrl: "/templates/homeView.html"
        })
        .when("/Profile", {
            controller: "AddProfileController",
            templateUrl: "/AngularApp/StaticViews/ProfileForm.html"
        })
        .when("/Profile/:id", {
            controller: "ProfileController",
            templateUrl: "/AngularApp/StaticViews/SOMETHING.html"
        })
        .when("/Quiz", {
            controller: "AddProfileController",
            templateUrl: "/AngularApp/StaticViews/ProfileForm.html"
        })
        .when("/Match", {
            controller: "AddProfileController",
            templateUrl: "/AngularApp/StaticViews/ProfileForm.html"
        })
        .otherwise({ redirectTo: "/" });
})