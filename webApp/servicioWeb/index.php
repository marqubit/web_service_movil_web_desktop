<?php
    //para permitir el traspaso de información se manera segura
    if (isset($_SERVER['HTTP_ORIGIN'])) {
        header("Access-Control-Allow-Origin: {$_SERVER['HTTP_ORIGIN']}");
        header('Access-Control-Allow-Credentials: true');
        header('Access-Control-Max-Age: 86400'); // cache for 1 day
    }
    
    //Para establecer que trabajaremos por método POST
	//Receiving JSON POST Data Via PHP.
    if(strcasecmp($_SERVER['REQUEST_METHOD'], 'POST') != 0){
        throw new Exception('El método debería ser POST!');
    }
    
    //Establece que el formato de entrada será application/json
    $contentType = isset($_SERVER["CONTENT_TYPE"]) ? trim($_SERVER["CONTENT_TYPE"]) : '';
    if(strcasecmp($contentType, 'application/json') != 0){
        throw new Exception('Content type must be: application/json');
    }

    //Recibe el RAW 
    $content = trim(file_get_contents("php://input"));

    //transforma el RAW JSON a PHP
    $decoded = json_decode($content, true); //guarda la petición
    
    $message = array(); //para guardar la respuesta
    
    require 'config/Conexion.php';
    require 'api/apiTest.php';
    
    $miAPI = new Consultas();
    
 switch ($decoded['action']) {
    case "canciones":
      if (is_array($data = $miAPI-> consultar())) {
			$message = $data;
      } else {
           $message["message"] = "Error en la acción canciones.";
      }        

       break;
       
    case "artistas":
      if (is_array($data = $miAPI->listarArtistas())) {
			$message = $data;
      } else {
           $message["message"] = "Error en la acción Listar Artistas.";
      }        

       break;
	   
	case "Generos":
      if (is_array($data = $miAPI->VerGeneros())) {
			$message = $data;
      } else {
           $message["message"] = "Error en la acción Listar Generos.";
      }        

       break;

	case "NumeroCancionPorGenero":
	if (is_array($data = $miAPI->Porgenero($decoded['genero']))) {
			$message = $data;
      } else {
           $message["message"] = "Error en la acción Listar el Conteo.";
      }
	  break;
	  
	  case "MostrarGeneArt":
      if (is_array($data = $miAPI->generojunto($decoded['']	))) {
			$message = $data;
      } else {
           $message["message"] = "Error en la acción Listar el Conteo.";
      }
	  break;
	case "Agregar":
		if (is_array($data = $miAPI->Insertar($decoded['genero']))) {
			$message = $data;
      } else {
           $message["message"] = "Error en la acción Listar el Conteo.";
      }	      
       break;
	   
    default:
         $message["message"] = "Acción NO válida";
        break;
		
}

//Codificar a JSON y mostrarlo en pantalla
header('Content-type: application/json; charset=utf-8');
$miJSON = json_encode($message, JSON_PRETTY_PRINT);
print $miJSON;