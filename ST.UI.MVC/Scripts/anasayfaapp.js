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
        },
        sepetionayla: function (model, success) {
            $http({
                url: baseUrl + '/Ana/SepetiOnayla',
                data: model,
                method: 'POST',
                dataType: 'JSON'
            }).then(function (response) {
                success(response.data);
            });
        },
        odemetipigetir: function (success) {
            $http({
                url: baseUrl + '/Ana/OdemeTipleriniGetir/',
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
    $scope.zaman = {
        tarih: new Date(),
        saat: new Date()
    };
    $scope.odemetipleri = [];
    $scope.odemetipi = {};
    $scope.KullaniciId = 0;
    function init() {
        api.firmaninurunlerinigetir($scope.firmaid, function (response) {
            console.log(response.data);
            $scope.data = response.data;
            $scope.minimumsiparistutari = response.data.MinimumSiparisTutari;
        });
        api.odemetipigetir(function (response) {
            $scope.odemetipleri = response;
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
    $scope.sepetionayla = function () {
        var model = {
            FirmaId: $scope.data.Id,
            SiparisTarihi: new Date(),
            OdemeTipiId:$scope.odemetipi,
            Urunler: $scope.sepet
        };
        if ($scope.hemenmi) {
            model.IstenilenTarih = new Date(new Date().getTime() + $scope.data.OrtalamaSiparisSuresi * 60000);
        } else {
            var dd = new Date($scope.zaman.tarih.getFullYear(), $scope.zaman.tarih.getMonth(), $scope.zaman.tarih.getDate(), $scope.zaman.saat.getHours(), $scope.zaman.saat.getMinutes());
            model.IstenilenTarih = dd;
        }
        api.sepetionayla(model, function (response) {
            console.log(response);
        });
    }
    setTimeout(function () {
        init();
    }, 200);
});