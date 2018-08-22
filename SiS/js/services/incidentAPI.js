angular.module("app").factory("incidentAPI", function ($http, config) {
	var baseUrl = (config.baseUrl + "incidents");

	var _getIncidents = function () {
		return $http.get(baseUrl + "/list-incidents");
	};

	var _getIncidentsId = function (id) {
		return $http.get(baseUrl + "/list-incident-id?id=" + id);		
	};

	var _addIncident = function (incident) {
		return $http.post(baseUrl + "/add-incident", incident);
	};

	var _updateIncident = function(incident){
		return $http.post(baseUrl + "/update-incident/", incident);
	};

	return {
		getIncidents: _getIncidents,
		getIncidentsId: _getIncidentsId,
		addIncident: _addIncident,
		updateIncident: _updateIncident,
	};
});

