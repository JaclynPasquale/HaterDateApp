var app = angular.module("HaterDateApp", ["ngRoute", "ngResource"])

app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            controller: "profileController",
            templateUrl: "/AngularApp/StaticViews/Landing.html"
        })
        .when("/Profile", {
            controller: "profileController",
            templateUrl: "/AngularApp/StaticViews/ProfileForm.html"
        })
        .when("/Profile/:id", {
            controller: "profileController",
            templateUrl: "/AngularApp/StaticViews/SOMETHING.html"
        })
        .when("/Quiz", {
            controller: "profileController",
            templateUrl: "/AngularApp/StaticViews/Quiz1.html"
        })
        .when("/Match", {
            controller: "profileController",
            templateUrl: "/AngularApp/StaticViews/Matches.html"
        })
        .otherwise({ redirectTo: "/" });
})