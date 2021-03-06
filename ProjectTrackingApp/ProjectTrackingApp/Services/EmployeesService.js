﻿(function () {
    var employeeService = function ($http) {
        var employees = function () {
            return $http.get("http://localhost:50006/api/ptemployees").then(function (serviceResp) {
                /*console.log(serviceResp.data);*/
                serviceResp.data
            });
            
        };
        var searchEmployees = function (employeeName) {
            return $http.get("http://localhost:50006/api/ptemployees/" + employeeName).then(function (serviceResp) {
                return serviceResp.data;
            });
        };
        return {
            employees: employees,
            searchEmployees: searchEmployees
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("employeeService", ["$http", employeeService]);
})();