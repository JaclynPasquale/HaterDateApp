var app = angular.module("HaterDateApp", ["ngRoute", "ngResource"])

app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            controller: "profileCtrl",
            templateUrl: "/AngularApp/StaticViews/Landing.html"
        })
        .when("/Profile", {
            controller: "profileCtrl",
            templateUrl: "/AngularApp/StaticViews/ProfileForm.html"
        })
        .when("/Profile/:id", {
            controller: "profileCtrl",
            templateUrl: "/AngularApp/StaticViews/ShowProfile.html"
        })
        .when("/Quiz", {
            controller: "questionCtrl",
            templateUrl: "/AngularApp/StaticViews/Quiz1.html"
        })
        .when("/Match", {
            controller: "matchCtrl",
            templateUrl: "/AngularApp/StaticViews/Matches.html"
        })
        .otherwise({ redirectTo: "/" });
})