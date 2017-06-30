var routerApp = angular.module('routerApp', ['ui.router','logermodule' ]);
/**
 * 由于整个应用都会和路由打交道，所以这里把$state和$stateParams这两个对象放到$rootScope上，方便其它地方引用和注入。
 * 这里的run方法只会在angular启动的时候运行一次。
 * @param  {[type]} $rootScope
 * @param  {[type]} $state
 * @param  {[type]} $stateParams
 * @return {[type]}
 */
routerApp.run(function ($rootScope, $state, $stateParams) {
    $rootScope.$state = $state;
    $rootScope.$stateParams = $stateParams;
});

routerApp.config(function ($stateProvider,$urlRouterProvider) {
    $urlRouterProvider.otherwise('/Loger');
    $stateProvider.state('index', {
        url: '/Loger',
        views: {
            '': {
                templateUrl: '/Home/Loger.html'
            }
        }
    })
})
var logermodule = angular.module('logermodule', []);

logermodule.controller("logerController", ['$scope', '$http', function ($scope, $http) {
    $scope.name = "www@qq.com";
    $scope.p = "123";

    $scope.loger = function () {
        $http({
            method:'GET',
            url: "/Home/loger",
            params: {
                'e': $scope.name,
                'p':$scope.p
            },
        }).success(function (data, status, config, headers) {
            
            if (data == "ok") {
                window.location = "/Admin/Index"
            }
            else {
                alert("你的用户名为 www@qq.com 或密码为 123");
            }

        })
        //$http.get('/Home/Loger', {
        //    params: {
        //        'username': $scope.username,
        //        'name': $scope.name,
        //    }
        //}).success(function (data, status, headers, config) {
        //    //加载成功之后做一些事  
        //    if (data == "ok") {

        //    } else {
        //        $scope.vm.id = true;
        //    }

        //}).error(function (data, status, headers, config) {
        //    //处理错误  
        //});


    }

}])

