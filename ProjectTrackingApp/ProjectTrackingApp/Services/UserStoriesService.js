(function () {
    var userStoriesService = function ($http) {
        var userStories = function () {
            return $http.get("http://localhost:50006/api/ptuserStories").then(function (serviceResp) {
                return serviceResp.data;
            });
        };
        var addUserStory = function (userStory) {
            return $http.post("http://localhost:50006/api/ptuserStories", userStory).then(function (result) {
                return result.data;
            });
        };
        return {
            userStories: userStories,
            addUserStory: addUserStory
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("userStoriesService", ["$http", userStoriesService]);
}());