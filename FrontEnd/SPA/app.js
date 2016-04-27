(function () {

    angular.module('tsi', [
        'ngRoute',
        // Custom modules 
        'edificios'
    ]);

    angular.module('tsi').config(['$routeProvider','$locationProvider', configFunction]);

    /*@ngInject*/
    function configFunction($routeProvider, $locationProvider) {
        $locationProvider.html5Mode({ enabled: true, requireBase: false}).hashPrefix('!');  

        // Routes
        $routeProvider
			.when("/crearEdificio", {
                templateUrl: "/SPA/edificios/crearEdificio.html",
                controller: "edificiosCtrl"
            })
            .when("/listarEdificios", {
                templateUrl: "listarEdificios.html",
                controller: "edificiosCtrl"
            }).otherwise({ redirectTo: '/' });
    }
})();