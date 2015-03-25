app.factory('profileFactory', function ($resource) {
    return {
        get: function () {
            return $resource('/api/profile').query();
        },

        getQuestions: function () {
            return $resource('/api/questions').query();
        },

        save: function (profile) {
            return $resource('/api/profile').save(profile);
        },

        saveDislike: function (question) {
            return $resource('/api/dislike').save(question);
        },


        getById: function () {
            return $resource('/api/profile/{id}').query();
        },
    }
}); 