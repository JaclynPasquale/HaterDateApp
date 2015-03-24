app.factory('profileFactory', function ($resource) {
    return {
        get: function () {
            return $resource('/api/profile').query();
        },

        save: function (profile) {
            return $resource('/api/profile').save(profile);
        }
    }
}); 