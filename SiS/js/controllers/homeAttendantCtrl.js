angular.module("app")
	.controller("homeAttendantCtrl", function($scope, $state, incidentAPI) {
			var vm = this;
			
			vm.incidentDetails = function (incidentId)  {
				$state.go('detailsAttendant', {
					id: incidentId
				});				
			}
		
			var loadIncidents = function () {         
				incidentAPI.getIncidents().then(function (response) {             
					$scope.incidents = response.data;
					console.log(response.data);
				}).catch(function (response) {             
					$scope.message = "Error!";         
				});     
			};
		
			loadIncidents();			
				
		})	
						
		