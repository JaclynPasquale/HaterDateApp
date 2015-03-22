
//.controller("GetProfileController", function ($scope, $http) {
//    $scope.data = [];

//    $http.get("/api/profiles")
//        .then(function (result) {
//            //success
//            console.log(result);
//            angular.copy(result.data, $scope.data);
//        },
//        function () {
//            alert("Something got fucked up somewhere, sorry")
//        })

//})
//.controller("AddProfileController", function ($scope, $http, $location) {
//    $scope.newProfile = {};

//    $scope.save = function () {
//        $http.post("api/profiles", $scope.newProfile)
//            .then(function (result) {
//                //Success
//                var newProfile = result.data;
//                console.log(newProfile);
//                $location.path("/");
//            },
//            function () {
//                //error
//                alert("Something went terribly wrong, your profile was not saved");
//            });
//    }
    app.controller('profileController', function ($scope, profileFactory, $location) {
        $scope.profile = profileFactory.get();
        $scope.newProfile = {};
        $scope.save = function () {
            profileFactory.save($scope.newProfile);
            $location.url("/Quiz");
        }
    })
