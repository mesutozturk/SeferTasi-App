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
        }
    }
});

app.controller("UrunKategoriCtrl",
    function ($scope, api) {
        $scope.kategoriler = [];
        function init() {
            api.urunkategorilerigetir(function(data) {
                $scope.kategoriler = data;
            });
        }
        $scope.ekle=function() {
            api.urunkategoriekle($scope.kategori,
                function (data) {
                    $scope.kategoriler = null;
                    console.log(data);
                    init();
                });
        }
        init();
    });