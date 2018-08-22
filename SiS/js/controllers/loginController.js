angular.module("app").controller("loginController", loginController) 
    function loginController($scope, $state, loginAPI,) {
    var vm = this;

    vm.logged = function (username, password) {
        var auth = {
            username: username,
            password: password
        };

        loginAPI.login(auth).then(function(response) {
            switch (response.data.typeId) {
                case 1:
                    $state.go("homeCollaborator", { response: auth.data });
                    break;
                case 2:
                    $state.go("homeAttendant");
                    break;
                default:
                    $scope.error = "Error! User and/or password incorrects.";
            }

        }).catch(function (response) {
            $scope.error = "Error! User and/or password incorrects.";
        });
    };
}

