registrationModule.factory('orderRepository', function ($http, $q) {

    return {

        get: function () {

            var deferred = $q.defer();
            $http.get('/Order').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }

    }

});