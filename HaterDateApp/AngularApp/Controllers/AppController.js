
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
app.controller('questionCtrl', function($scope, profileFactory, $location, $routeParams){
    $scope.questions = profileFactory.getQuestions();
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

//.controller('ShowCtrl', function ($scope, $routeParams, $location, profileFactory) {
//    var vm = this;
//    var id = $routeParams.id;
//    $http.get('https://library-app-angular.firebaseio.com/' + id + '.json')
//      .success(function (data) {
//          vm.question = data;
//      })
//      .error(function (err) {
//          console.log(err);
//      })
//})
