angular.module("app")
    .controller("detailsAttendantCtrl", function (detail, incidentAPI, $scope) {
        var vm = this;
        details(detail);

        function details(selection) {
            vm.incident = selection.data;
            console.log(selection.data);
        }

       
        vm.save = function (IM){
            incidentAPI.updateIncident(IM).then(function(){
                alert("Sucess!");
            })
        }
    });

