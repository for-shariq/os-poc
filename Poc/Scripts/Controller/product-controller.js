registrationModule.controller("ProductController", function ($scope, productRepository) {
    productRepository.get().then(function (products) {
        $scope.products = products;
    }, function () { });
   // $scope.products = bootstrappedData.products;
});