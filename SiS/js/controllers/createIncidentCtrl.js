angular.module("app")
	.controller("createIncidentCtrl", function ($scope, incidentAPI, $location) {
		var vm = this;

		vm.addIncident = function (title, description, categoryId)
		 {
			var incident = {
				title: title,
				description: description,
				dateOpen: new Date(),
				statusId: 1, 
				categoryId: categoryId,				
				User_ID: 1,
			};
			
			console.log(incident)

			incidentAPI.addIncident(incident).then(function (response) {
				$scope.incidents = response.data;
				alert("Sucess!")
           		$state.go('homeAttendant');
				loadIncidents();
			}).catch(function (response) {
				$scope.message = "Add incidents fail!";
		
			});
		};
	});
			

