angular.module("app")
	.controller("homeCollaboratorCtrl", function($scope, $state, incidentAPI) {
		var vm = this;
			
		vm.incidentDetails = function (incidentId)  {
			$state.go('detailsCollaborator', {
				id: incidentId
			});				
		}
	
		var loadIncidents = function () {         
			incidentAPI.getIncidents().then(function (response) {             
				$scope.incidents = response.data;
			}).catch(function (response) {             
				$scope.message = "Error!";         
			});     
		};
	
		loadIncidents();			
			
	})	
						
		
		