(function () {
    var HomeController = function ($scope) {
        $scope.message = "Welcome to Online Project Tracking Website";
        $scope.slides = [
            {
                header: "Manage your projects!!",
                body: "This site is usedd for managing projects. A single Tool to manage all your projects!!",
                button: "More Details"
            },
            {
                header: "Add your stories!!",
                body: "You can add different user stories as a Business Administrators. Your stories will be from the project task.",
                button: "User Stories"
            },
            {
                header: "Manager Comments!!",
                body: "Manager can add comments for the task which are going under your project.",
                button: "Manager Comments"
            },
            {
                header: "Employee List!!",
                body: "You can see all the employee details with their skill sets to assign the appropriate tasks and do efficcient project management.",
                button: "Let Me Try!"
            },
            {
                header: "Track Project Progress",
                body: "You can track project progress of all employees who are working under that project. You can also see the report for individual employee and his/her performance.",
                button: "More Details"
            }
        ];
        console.log($scope.slides);
    };
    app.controller("HomeController", ["$scope", HomeController]);
}());