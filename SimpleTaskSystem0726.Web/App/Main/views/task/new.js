(function () {
    var app = angular.module('app');

    var controllerId = "sts.views.task.new";
    app.controller(controllerId, [
        '$scope', '$location', 'abp.services.tasksystem.task', 'abp.services.tasksystem.person',
        function ($scope, $location, taskService, personService) {
            var vm = this;

            vm.task = {
                description: '',
                assignedPersonId: null
            };

            var localize = abp.localization.getSource('SimpleTaskSystem0726');
            vm.people = [];

            personService.getAllPeople().then(function (data) {
                vm.people = data.data.people;
            });

            vm.saveTask = function () {
                abp.ui.setBusy(
                    null,
                    taskService.createTask(
                        vm.task
                    ).then(function () {
                        abp.notify.info(abp.utils.formatString(localize("TaskCreateMessage"), vm.task.description));
                        $location.path('/');
                    })
                );
            };
        }
    ]);
})();