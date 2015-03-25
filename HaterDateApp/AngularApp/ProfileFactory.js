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

        saveDislike: function (dislike, profileId) {
            return $resource('/api/questions').saveDislike(dislike);
        },


        getById: function () {
            return $resource('/api/profile/{id}').query();
        },
    }
}); 