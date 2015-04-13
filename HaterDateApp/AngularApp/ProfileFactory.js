app.factory('profileFactory', function ($resource) {
    return {
        get: function () {
            return $resource('/api/myprofile').get();
        },
        getProfiles: function () {
            return $resource('/api/profiles').query();
        },
        getMatches: function () {
            return $resource('/api/matches').query();
        },
        getQuestions: function () {
            return $resource('/api/questions').query();
        },
        getDislike: function () {
            return $resource('/api/dislikes').query();
        }

        save: function (profile) {
            return $resource('/api/profiles').save(profile);
        },

        saveDislike: function (question) {
            return $resource('/api/dislike').save(question);
        },


        getById: function () {
            return $resource('/api/profile/{id}').query();
        },
    }
}); 