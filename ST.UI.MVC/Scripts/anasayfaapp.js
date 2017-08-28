/// <reference path="angular.js"/>

var app = angular.module("site", ['angular.filter']);
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
    function init() {
        api.firmaninurunlerinigetir($scope.firmaid, function (response) {
            console.log(response.data);
            $scope.data = response.data;
        });
    }

    setTimeout(function () {
        init();
    }, 500);
});