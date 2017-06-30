var Adminrouter = angular.module("Adminrouter", ["ui.router", "ExamModule"]);

Adminrouter.config(function ($stateProvider,$urlRouterProvider) {
    $urlRouterProvider.otherwise('/Admin');
    $stateProvider.state('Admin', {

        url: '/Admin',
        views: {
            '': {
                templateUrl: '/Admin/Index.html'
            },
            'Exam@Admin': {
                templateUrl: '/Admin/Home.html'
                 }
        }


    })
    .state('Exa', {
        url: '/Exa',
        views: {
            '': {
                templateUrl: '/Admin/Index.html'
            },
            'Exam@Exa': {
                templateUrl: '/Admin/Exam.html'
            }
        }
    })
    .state('KuMu', {
        url: '/KuMu',
        views: {
            '': {
                templateUrl: '/Admin/Index.html'
            },
            'Exam@KuMu': {
                templateUrl: '/Admin/KuMu.html'
                }
        }

    })
    .state("KaoSheng", {

        url: '/KaoSheng',
        views: {
            '': {
                templateUrl:'/Admin/Index.html'
            },
            'Exam@KaoSheng': {
                templateUrl: '/Admin/KaoSheng.html'
            }
        }


    })
    .state('ChengJi', {
        url: '/ChengJi',
        views: {
            '': {
                templateUrl:'/Admin/Index.html'
            },
            'Exam@ChengJi': {
                templateUrl: '/Admin/ChengJi.html'
            }
        }
    })
    .state('ShengKe', {
        url: '/ShengKe',
        views: {
            '': {
                templateUrl:'/Admin/Index.html'
            },
            'Exam@ShengKe': {
                templateUrl:'/Admin/ShengKe.html'
            }
        }

    })
    .state('SheZhi', {
        url: '/SheZhi',
        views: {
            '': {
                templateUrl:'/Admin/Index.html'
            },
            'Exam@SheZhi': {
                templateUrl:'/Admin/SheZhi.html'
            }
        }
    })
    .state('Exam-from', {
        url: '/Exam-from',
        views: {
            '': {
                templateUrl:'/Admin/Index.html'
            },
            'Exam@Exam-from': {
                templateUrl: '/Admin/Exam-from.html'
            }
        }
    })



})


Adminrouter.controller("AdminController", ["$scope", function ($scope) {
    var vm = $scope.vm = {};
    vm.amin = true;
    $scope.amin = function () {
        vm.amin == true ? vm.amin = false : vm.amin = true;
    }

   

}])




