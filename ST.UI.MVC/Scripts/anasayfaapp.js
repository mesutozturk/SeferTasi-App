/// <reference path="angular.js"/>

var app = angular.module("site", ['angular.filter', 'ngMaterial']);
app.factory("api", function ($http, $location) {
    var baseUrl = $location.$$protocol + "://" + $location.$$host;
    if ($location.$$port)
        baseUrl += ":" + $location.$$port;
    return {
        firmaninurunlerinigetir: function (id, success) {
            $http({
                url: baseUrl + '/Ana/FirmaninUrunleriniGetir/' + id,
                method: 'GET',
                dataType: 'JSON'
            }).then(function (response) {
                success(response.data);
            });
        }
    }

});
app.controller("SepetCtrl", function ($scope, api) {
    $scope.data = null;
    $scope.firmaid = 0;
    $scope.sepet = [];
    $scope.minimumsiparistutari = 0;
    $scope.sepettutari = 0;
    $scope.hemenmi = true;
    function init() {
        api.firmaninurunlerinigetir($scope.firmaid, function (response) {
            console.log(response.data);
            $scope.data = response.data;
            $scope.minimumsiparistutari = response.data.MinimumSiparisTutari;
        });
    }
    $scope.sepeteekle = function (urun) {
        var urunvarmi = false;
        for (var i = 0; i < $scope.sepet.length; i++) {
            if ($scope.sepet[i].UrunId === urun.UrunId) {
                urunvarmi = true;
                $scope.sepet[i].Adet++;
                break;
            }
        }
        if (!urunvarmi) {
            urun.Adet = 1;
            $scope.sepet.push(urun);
        }
        sepetiHesapla();
    };
    $scope.adetarttir = function (urun) {
        for (var i = 0; i < $scope.sepet.length; i++) {
            if ($scope.sepet[i].UrunId === urun.UrunId) {
                $scope.sepet[i].Adet = urun.Adet;
                break;
            }
        }
        sepetiHesapla();
    }
    function sepetiHesapla() {
        $scope.sepettutari = 0
        for (var i = 0; i < $scope.sepet.length; i++) {
            $scope.sepettutari += $scope.sepet[i].Fiyat * $scope.sepet[i].Adet;
        }
        //$scope.$apply;
    }
    $scope.sepettencikart = function (urun) {
        for (var i = 0; i < $scope.sepet.length; i++) {
            if ($scope.sepet[i].UrunId === urun.UrunId) {
                $scope.sepet.splice(i, 1);
                break;
            }
        }
        sepetiHesapla();
    }
    setTimeout(function () {
        init();
    }, 200);
});