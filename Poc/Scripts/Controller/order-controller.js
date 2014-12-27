registrationModule.controller("OrderController", function ($scope, orderRepository) {

    orderRepository.get().then(function (orders) {

        $scope.orders = orders;
    });
  //  $scope.orders = bootstrappedData.orders;
});