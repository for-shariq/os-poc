registrationModule.controller("OrderController", function ($scope, bootstrappedDataOrders) {
    $scope.orders = bootstrappedDataOrders.orders;
});