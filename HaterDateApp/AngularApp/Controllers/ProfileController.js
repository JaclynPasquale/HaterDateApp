angular.module("HaterDateApp", [])
.controller("ProfileController", function ($scope, $http) {
    $scope.data = [];

    $http.get("/api/profiles")
        .then(function (result) {
            //success
            console.log(result);
            angular.copy(result.data, $scope.data);
        },
        function () {
            alert("Something got fucked up somewhere, sorry")
        })

})
.controller("NewProfileController", function ($scope, $http, $location) {
    $scope.newProfile = {};

    $scope.save = function () {
        $http.post("api/profiles", $scope.newProfile)
            .then(function (result) {
                //Success
                var newProfile = result.data;
                console.log(newAlbum);
                $location.path("/");
            },
            function () {
                //error
                alert("Something went terribly wrong, your profile was not saved");
            });
    }
})