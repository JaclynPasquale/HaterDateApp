app.factory('profileFactory', function ($resource) {
    return {
        get: function () {
            return $resource('/api/profile').query();
        },

        save: function (profile) {
            return $resource('/api/profile').save(profile);
        },

        saveDislike: function (dislike) {
            return $resource('/api/quiz').save(dislike);
        },


        getById: function () {
            return $resource('/api/profile/{id}').query();
        },
    }
}); 