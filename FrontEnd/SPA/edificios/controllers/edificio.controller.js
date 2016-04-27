(function () {
    'use strict';
    angular.module('edificios').controller("edificiosCtrl", ["edificiosService", '$scope', edificiosCtrl]);

    function edificiosCtrl(edificiosService, $scope) {

       // function(edificiosService, $scope) {
            $scope.title = "Lista Edificios";

            $scope.listaEdificios = {
                0 :
                    {
                        Nombre: "Cuartel",
                        Imagen: "/SPA/edificios/cuartel.jpg",
                        Vida: 500,
                        Ataque: 12,
                        Defensa: 30,
                        Tasa: "20/s"
                    },
                1 :
                    {
                        Nombre: "Granja",
                        Imagen: "/SPA/edificios/granja.jpg",
                        Vida: 450,
                        Ataque: 0,
                        Defensa: 10,
                        Tasa: "100/s"
                    }
            }
            console.debug($scope.listaEdificios);
       // }
    }    
})();