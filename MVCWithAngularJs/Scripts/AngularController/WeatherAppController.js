angular.module('MyApp') // extending from previously created angularJS  module in the First part
    .controller('WeatherAppController', function ($scope, LocationService) {
    // LocationService (Service) Injected

    $scope.CountryID = null;
    $scope.CityID = null;
    $scope.CountryList = null;
    $scope.CityList = null;

    $scope.CityTextToShow = "Select City";
    //$scope.Result = "";
    $scope.Result = null;
    $scope.IsVisible = false;

    // Populate Country
    LocationService.GetCountry().then(function (d) {
        $scope.CountryList = d.data;
    }, function (error) {
        alert('Error!');
    });
    // Function For Populate City  // This function we will call after select change country
    $scope.GetCity = function () {
        $scope.CityID = null; // Clear Selected City if any
        $scope.CityList = null; // Clear previously loaded city list
        $scope.CityTextToShow = "Please Wait..."; // this will show until load states from database

        //Load City 
        LocationService.GetCity($scope.CountryID).then(function (d) {
            $scope.CityList = d.data;
            $scope.CityTextToShow = "Select City";
        }, function (error) {
            alert('Error!');
        });

    }
    // Function for show result
    $scope.ShowResult = function () {
        
        $scope.IsVisible = true;
        //Load Weather 
        LocationService.GetWeather($scope.CityID).then(function (d) {
            $scope.Result = d.data;
           
        }, function (error) {
            alert('Error!');
        });
    }

})
.factory('LocationService', function ($http) { // explained about factory in Part2
    var fac = {};
    fac.GetCountry = function () {
        return $http.get('/Data/GetCountries')
    }
    fac.GetCity = function (countryID) {
        return $http.get('/Data/GetCities?countryID='+countryID)
    }

    fac.GetWeather = function (cityID) {
        return $http.get('/Data/GetWeather?cityID='+ cityID)
    }


    return fac;
});