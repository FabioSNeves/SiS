angular.module("app").factory("loginAPI", function ($http, config) {
	var baseUrl = (config.baseUrl + 'user/auth');

	var _login = function (userModel) {
		return $http.post(baseUrl, userModel);
    };
    
    return {
		login: _login,
	};
});
