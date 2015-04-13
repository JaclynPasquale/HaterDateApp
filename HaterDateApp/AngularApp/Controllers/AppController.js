

app.controller('MyprofileCtrl', function ($scope, profileFactory, $location) {
    $scope.profile = profileFactory.get();
    console.log($scope.profile);
    //$scope.dislike = profileFactory.
    $location.url("/MyProfile");
});

app.controller('profileCtrl', function ($scope, profileFactory, $location) {
    $scope.profile = profileFactory.get();
    console.log($scope.profile);
    $scope.newProfile = {};
    $scope.save = function () {
        profileFactory.save($scope.newProfile);
        $location.url("/Quiz");
    }

    getProfile = function () {
        $scope.profile = profileFactory.getProfiles();
    }
});
app.controller('questionCtrl', function($scope, profileFactory, $location, $routeParams){
    $scope.questions = profileFactory.getQuestions();
    alert($scope.questions);
    $scope.newQuestion = {};
    $scope.save = function () {
        profileFactory.saveDislike($scope.newQuestion);
        $location.url("/Matches")
    }

    $scope.q = $routeParams.id;
    profileFactory.getQuestions()

    $scope.nextQuestion = function()
    {
        var question = { QuestionId: $scope.q, QuestionValue: $scope.Dislike.QuestionValue };
        profileFactory.saveDislike(question);
        $location.path("/Quiz/" + ++$scope.q );
    }
})

app.controller('matchCtrl', function ($scope, $location, profileFactory) {
    $scope.matches = profileFactory.getMatches();
  


    
})
