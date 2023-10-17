<?php
    // Construimos la URL del API con los parámetros
    $url = "http://localhost/api/api.php?x=10&y=55";

    // Realizamos la llamada al API mediante cURL
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    $response = curl_exec($ch);
    curl_close($ch);

    // Mostramos la respuesta del API
    echo "El resultado de la suma es: $response";
?>