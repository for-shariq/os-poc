var registrationModule = angular.module("registrationModule", []);
var registrationModule = angular.module('registrationModule', ['ngRoute']);

registrationModule.config(function ($routeProvider, $locationProvider) {
    $routeProvider.when('/Store/Product', { templateUrl: '/templates/Products.html', controller: 'ProductController' });
    $routeProvider.when('/Store/Order', { templateUrl: '/templates/Orders.html', controller: 'OrderController' });
    $locationProvider.html5Mode(true);
});