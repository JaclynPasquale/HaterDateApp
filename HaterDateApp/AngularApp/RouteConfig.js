var app = angular.module("HaterDateApp", ["ngRoute", "ngResource"])

app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            controller: "landingCtrl",
            templateUrl: "/AngularApp/StaticViews/Landing.html"
        })
        .when("/ProfileForm", {
            controller: "profileCtrl",
            templateUrl: "/AngularApp/StaticViews/ProfileForm.html"
        })
        .when("/MyProfile", {
            controller: "profileCtrl",
            templateUrl: "/AngularApp/StaticViews/ShowProfile.html"
        })
        .when("/Profile/:id", {
            controller: "profileCtrl",
            templateUrl: "/AngularApp/StaticViews/ShowProfile.html"
        })
        .when("/Quiz/:id", {
            controller: "questionCtrl",
            templateUrl: "/AngularApp/StaticViews/Quiz1.html"
        })
        .when("/Matches", {
            controller: "matchCtrl",
            templateUrl: "/AngularApp/StaticViews/Matches.html"
        })
        .otherwise({ redirectTo: "/" });
})