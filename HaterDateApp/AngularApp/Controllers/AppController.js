
app.controller('profileCtrl', function ($scope, profileFactory, $location) {
    $scope.profile = profileFactory.get();
    $scope.newProfile = {};
    $scope.save = function () {
        profileFactory.save($scope.newProfile);
        $location.url("/Quiz");
    }

    getProfile = function () {
        $scope.profile = profileFactory.get();
    }
});
app.controller('questionCtrl', function($scope, profileFactory, $location){
    $scope.questions = profileFactory.getQuestions();
    $scope.newQuestion = {};
    $scope.save = function () {
        profileFactory.saveDislike($scope.newQuestion);
        $location.url("/Matches")
    }
    //var n = 0;
    //$scope.activeQuestion = $scope.questions[0];


})
