//https://developers.google.com/maps/documentation/javascript/tutorials/firebase
function Init(Lat, Long) {
    var image = window.location.origin + '/img/icon.png';
    var myLatLng = { lat: parseFloat(Lat), lng: parseFloat(Long) };
    var map = new google.maps.Map(document.getElementById('mapContainer'), {
        center: myLatLng,
        //position: { lat: 0, lng: 0 },
        zoom: 15,
        mapTypeId: google.maps.MapTypeId.ROADMAP,
        styles: [{
            featureType: 'poi',
            stylers: [{ visibility: 'on' }]  // Turn off points of interest.
        }, {
            featureType: 'transit.station',
            stylers: [{ visibility: 'off' }]  // Turn off bus stations, train stations, etc.
        }],
        disableDoubleClickZoom: true
    });

    map.setPadding(15,0,0,0);

    var marker = new google.maps.Marker({
        position: myLatLng,
        map: map,
        title: 'Pura Vida with Akchete',
        icon: image
    }); 
}

//~/img/Header6.png