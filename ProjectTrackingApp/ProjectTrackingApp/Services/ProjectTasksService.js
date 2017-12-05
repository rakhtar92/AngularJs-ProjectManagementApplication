(function () {
    var projectTasksService = function ($http) {
        var projectTasks = function () {
            return $http.get("http://localhost:50006/api/ptprojectTasks").then(function (serviceResp) {
                return serviceResp.data;
            });
        };
        var addProjectTask = function () {
            return $http.post("http://localhost:50006/api/ptprojectTasks", task).then(function (response) {
                return response.data;
            });
        };
        return {
            projectTasks: projectTasks,
            addProjectTask: addProjectTask
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("projectTasksService", ["$http", projectTasksService]);
}());