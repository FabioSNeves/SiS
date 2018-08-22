var app = angular.module('app', ['ui.router']);
app.config(['$stateProvider', '$urlRouterProvider', function($stateProvider, $urlRouterProvider) {
        
    $urlRouterProvider.otherwise('/login');
 
  $stateProvider
    .state('login', {
    url: '/login',
    templateUrl: 'view/login.html',
    controller: 'loginController',
    controllerAs: 'vm',
  })

  .state('homeCollaborator', {
    url: '/homeCollaborator',
    templateUrl: 'view/homeCollaborator.html',
    controller: 'homeCollaboratorCtrl',
    controllerAs: 'vm'
  })

  .state('homeAttendant', {
    url: '/homeAttendant',
    templateUrl: 'view/homeAttendant.html',
    controller: 'homeAttendantCtrl',
    controllerAs: 'vm'			
	})

  .state('detailsAttendant', {
    url: '/detailsAttendant',
    templateUrl: 'view/detailsAttendant.html',
    controller: 'detailsAttendantCtrl',
    controllerAs: 'vm',
    params: {
      id: 0
    },
    resolve: {
      detail: ['incidentAPI', '$stateParams', function (incidentAPI, $stateParams) {
          return incidentAPI.getIncidentsId($stateParams.id);
      }]
    }
  })

  .state('detailsCollaborator', {
    url: '/detailsCollaborator',
    templateUrl: 'view/detailsCollaborator.html',
    controller: 'detailsCollaboratorCtrl',
    controllerAs: 'vm',
    params: {
      id: 0
    },
    resolve: {
      detail: ['incidentAPI', '$stateParams', function (incidentAPI, $stateParams) {
          return incidentAPI.getIncidentsId($stateParams.id);
      }]
    }
  })

  .state('createIncident', {
     url: '/createIncident',
     templateUrl: 'view/createIncident.html',
     controller: 'createIncidentCtrl',
     controllerAs: 'vm'			
  })
}]);

