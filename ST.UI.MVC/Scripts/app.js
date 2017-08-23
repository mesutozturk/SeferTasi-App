/// <reference path="angular.js"/>

var app = angular.module("admin", []);

app.factory("api", function ($http) {
    var apiurl = "http://localhost:7723/Yonetim/";
    return {
        urunkategoriekle: function (model, success) {
            $http({
                url: apiurl + 'UrunKategori/Ekle',
                data: model,
                method: 'POST',
                dataType: 'JSON'
            }).then(function (response) {
                success(response.data);
            });
        },
        urunkategorilerigetir: function (success) {
            $http({
                url: apiurl + 'UrunKategori/Getir',
                method: 'GET',
                dataType: 'JSON'
            }).then(function (response) {
                success(response.data);
            });
        },
        urunkategoriguncelle: function (model, success) {
            $http({
                url: apiurl + 'UrunKategori/Guncelle',
                data: model,
                method: 'POST',
                dataType: 'JSON'
            }).then(function (response) {
                success(response.data);
            });
        },
        urunkategorisil: function (id, success) {
            $http({
                url: apiurl + 'UrunKategori/Sil/' + id,
                method: 'POST',
                dataType: 'JSON'
            }).then(function (response) {
                success(response.data);
            });
        }
    }
});

app.controller("UrunKategoriCtrl",
    function ($scope, api) {
        $scope.kategori = {};
        $scope.kategoriler = [];
        $scope.duzenlenecek = null;
        function init() {
            api.urunkategorilerigetir(function (data) {
                $scope.kategoriler = data;
            });
        }
        $scope.ekle = function () {
            console.log($scope.kategori);
            api.urunkategoriekle($scope.kategori,
                function (data) {
                    init();
                    console.log(data);
                    alert(data.message);
                });
        }
        $scope.duzenle = function (kategori) {
            $scope.duzenlenecek = {
                Id: kategori.Id,
                KategoriAdi: kategori.KategoriAdi,
                Aciklama: kategori.Aciklama
            };
        }
        $scope.guncelle = function () {
            api.urunkategoriguncelle($scope.duzenlenecek,
                function (data) {
                    console.log(data);
                    init();
                    alert(data.message);
                    if (data.success === true)
                        $scope.duzenlenecek = null;
                });
        }
        $scope.sil = function (id) {
            api.urunkategorisil(id,
                function (data) {
                    console.log(data);
                    init();
                    alert(data.message);
                });
        }
        init();
    });