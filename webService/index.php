<?php
    //para permitir el traspaso de información se manera segura
    if (isset($_SERVER['HTTP_ORIGIN'])) {
        header("Access-Control-Allow-Origin: {$_SERVER['HTTP_ORIGIN']}");
        header('Access-Control-Allow-Credentials: true');
        header('Access-Control-Max-Age: 86400'); // cache for 1 day
    }
    //Para establecer que trabajaremos por método POST
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
        /*
        *Casos para Administrar Clientes
        */
        /*
        *Casos para Administrar Clientes
        */
        /*
        *Casos para Administrar Clientes
        */
        /*
        *Casos para Administrar Clientes
        */
        /*
        *Casos para Administrar Clientes
        */
        case "consultar_clientes":
            if (is_array($data = $miAPI->consultar_clientes())) {
                $message = $data;
            } else {
                $message["message"] = "Error en la acción consultar clientes.";
            }        
            break;
        case "consultar_clientes_por_id":
            if(isset($decoded['id_Cliente'])){
                if (is_array($data = $miAPI->consultar_clientes_por_id($decoded['id_Cliente']))) {
                    $message = $data;
                } else {
                    $message["message"] = "Error en la acción consultar clientes.";
                }
            }
            else{
                   $message["message"] = "Error, Faltan datos";
            }        
            break;
        case "agregar_cliente":
            if(isset($decoded['RFC']) 
                and isset($decoded['nombre']) 
                and isset($decoded['apellido']) 
                and isset($decoded['colonia']) 
                and isset($decoded['municipio']) 
                and isset($decoded['tenencia']) 
                and isset($decoded['reg']) 
                and isset($decoded['manzana']) 
                and isset($decoded['lote']) 
                and isset($decoded['cPostal']) 
                and isset($decoded['telefono']) 
                and isset($decoded['celular'])
                ){
                if (is_array($data = $miAPI->agregar_cliente(
                    $decoded['RFC'], $decoded['nombre'], $decoded['apellido'], 
                    $decoded['colonia'], $decoded['municipio'], $decoded['tenencia'], 
                    $decoded['reg'], $decoded['manzana'], $decoded['lote'], 
                    $decoded['cPostal'], $decoded['telefono'], $decoded['celular'] ))) {
                    $message = $data;
                } else {
                    $message["message"] = "Error al intentar insertar dato.";
                }  
            }
                else{
                   $message["message"] = "Error, Faltan datos";
            }
            break;
        case "editar_cliente":
            if(
                isset($decoded['id_Cliente']) 
                and isset($decoded['RFC']) 
                and isset($decoded['nombre']) 
                and isset($decoded['apellido']) 
                and isset($decoded['colonia']) 
                and isset($decoded['municipio']) 
                and isset($decoded['tenencia']) 
                and isset($decoded['reg']) 
                and isset($decoded['manzana']) 
                and isset($decoded['lote']) 
                and isset($decoded['cPostal']) 
                and isset($decoded['telefono']) 
                and isset($decoded['celular'])
                ){
                if (
                    is_array(
                        $data = $miAPI->editar_cliente(
                            $decoded['id_Cliente'], $decoded['RFC'], 
                            $decoded['nombre'], $decoded['apellido'], 
                            $decoded['colonia'], $decoded['municipio'], 
                            $decoded['tenencia'], $decoded['reg'], 
                            $decoded['manzana'], $decoded['lote'], 
                            $decoded['cPostal'], $decoded['telefono'], 
                            $decoded['celular'] 
                            )
                        )
                    ) {
                        $message = $data;
                }else {
                    $message["message"] = "Error al intentar actualizar el cliente.";
                }  
            }else{
                $message["message"] = "Error, Faltan datos";
            }
            break;
        case "eliminar_cliente":
            if(isset($decoded['id_Cliente'])){
                if (is_array($data = $miAPI->eliminar_cliente($decoded['id_Cliente']))) {
                    $message = $data;
                } else {
                    $message["message"] = "Error al intentar eliminar el cliente.";
                }  
            }else{
                $message["message"] = "Error, Faltan datos";
            }
            break;
        /*
        *Casos para Administrar Avaluos
        */
        /*
        *Casos para Administrar Avaluos
        */
        /*
        *Casos para Administrar Avaluos
        */
        /*
        *Casos para Administrar Avaluos
        */
        /*
        *Casos para Administrar Avaluos
        */
        case "consultar_avaluos":
            if (is_array($data = $miAPI->consultar_avaluos())) {
                $message = $data;
            }else {
                $message["message"] = "Error en la acción mostrarl avaluos.";
            }        
            break;
        case "consultar_avaluos_por_id":
            if(isset($decoded['id_Avaluo'])){
                if (is_array($data = $miAPI->consultar_avaluos_por_id($decoded['id_Avaluo']))) {
                    $message = $data;
                } else {
                    $message["message"] = "Error en la acción consultar avaluos.";
                }
            }
            else{
                   $message["message"] = "Error, Faltan datos";
            }           
            break;
//    public public function agregar_avaluo($tipo, $pagoCatastro, $fecha, $cto_Avaluo, $subtotal, $total, $id_Cliente)
        case "agregar_avaluo":
            if(
                isset($decoded['tipo']) 
                and isset($decoded['pago_catastro']) 
                and isset($decoded['fecha']) 
                and isset($decoded['cto_Avaluo']) 
                and isset($decoded['subtotal']) 
                and isset($decoded['total']) 
                and isset($decoded['id_Cliente'])
                ){
                    if (
                        is_array(
                            $data = $miAPI->agregar_avaluo(
                                $decoded['tipo'], $decoded['pago_catastro'], 
                                $decoded['fecha'], $decoded['cto_Avaluo'], 
                                $decoded['subtotal'], $decoded['total'], 
                                $decoded['id_Cliente']
                                )
                            )
                        ){
                        $message = $data;
                    } else {
                       $message["message"] = "Error al intentar insertar dato.";
                    }  
                }
                else{
                   $message["message"] = "Error, Faltan datos";
            }
            break;

        case "editar_avaluo":
        //public function editar_avaluo($tipo, $pagoCatastro, $fecha, $cto_Avaluo, $subtotal, $total, $id_Cliente, $id_Avaluo)
            if(isset($decoded['id_Avaluo']) 
                and isset($decoded['tipo']) 
                and isset($decoded['pago_catastro']) 
                and isset($decoded['fecha']) 
                and isset($decoded['cto_Avaluo']) 
                and isset($decoded['subtotal']) 
                and isset($decoded['total']) 
                and isset($decoded['id_Cliente'])){
                if (is_array($data = $miAPI->editar_avaluo($decoded['tipo'], 
                    $decoded['pago_catastro'], 
                    $decoded['fecha'], 
                    $decoded['cto_Avaluo'], 
                    $decoded['subtotal'], 
                    $decoded['total'], 
                    $decoded['id_Cliente'],
                    $decoded['id_Avaluo']
                    )
                    )) {
                    $message = $data;
                }else {
                    $message["message"] = "Error al intentar actualizar el avaluo.";
                }  
            }else{
                $message["message"] = "Error, Faltan datos";
            }
            break;

        case "eliminar_avaluo":
            if(isset($decoded['id_Avaluo'])){
                if (is_array($data = $miAPI->eliminar_avaluo($decoded['id_Avaluo']))) {
                    $message = $data;
                } else {
                    $message["message"] = "Error al intentar eliminar el avaluo.";
                }  
            }else{
                $message["message"] = "Error, Faltan datos";
            }
            break;
        /*
        *Casos para Administrar Conceptos
        */
        /*
        *Casos para Administrar Conceptos
        */
        /*
        *Casos para Administrar Conceptos
        */
        /*
        *Casos para Administrar Conceptos
        */
        /*
        *Casos para Administrar Conceptos
        */
        case "consultar_conceptos":
            if (is_array($data = $miAPI->consultar_conceptos())) {
                $message = $data;
            } else {
                $message["message"] = "Error en la acción consultar conceptos.";
            }        
            break;
        case "consultar_conceptos_por_id":
            if(isset($decoded['id_Concepto'])){
                if (is_array($data = $miAPI->consultar_conceptos_por_id($decoded['id_Concepto']))) {
                    $message = $data;
                } else {
                    $message["message"] = "Error en la acción consultar conceptos.";
                }
            }
            else{
                   $message["message"] = "Error, Faltan datos";
            }           
            break;
        case "agregar_concepto":
            if(
                isset($decoded['motivo']) 
                and isset($decoded['ubicacion_predio']) 
                and isset($decoded['localidad']) 
                and isset($decoded['adquiriente']) 
                and isset($decoded['ubicacion']) 
                and isset($decoded['domicilio_notificar']) 
                and isset($decoded['localidad_notificar']) 
                and isset($decoded['no_cuenta']) 
                and isset($decoded['enajenante']) 
                and isset($decoded['fecha']) 
                and isset($decoded['id_Avaluo'])
                ){
                if (
                    is_array(
                    $data = $miAPI->agregar_concepto(
                    $decoded['motivo'], $decoded['ubicacion_predio'], 
                    $decoded['localidad'], $decoded['adquiriente'], 
                    $decoded['ubicacion'], $decoded['domicilio_notificar'], 
                    $decoded['localidad_notificar'], $decoded['no_cuenta'], 
                    $decoded['enajenante'], $decoded['fecha'], 
                    $decoded['id_Avaluo']))) {
                    $message = $data;
                } else {
                   $message["message"] = "Error al intentar insertar dato.";
                }  
            }
                else{
                   $message["message"] = "Error, Faltan datos";
            }
            break;
/*

public function editar_concepto(
        $idConcepto, 
        $motivo, 
        $ubicacion_predio, 
        $localidad, 
        $adquiriente, 
        $ubicacion, 
        $domicilio_notificar, 
        $localidad_notificar, 
        $no_cuenta, 
        $enajenante, 
        $fecha, 
        $id_Avaluo
        )

*/
        case "editar_concepto":
            if(
                isset($decoded['id_Concepto']) 
                and isset($decoded['motivo']) 
                and isset($decoded['ubicacion_predio']) 
                and isset($decoded['localidad']) 
                and isset($decoded['adquiriente']) 
                and isset($decoded['ubicacion']) 
                and isset($decoded['domicilio_notificar']) 
                and isset($decoded['localidad_notificar']) 
                and isset($decoded['no_cuenta']) 
                and isset($decoded['enajenante']) 
                and isset($decoded['fecha']) 
                and isset($decoded['id_Avaluo'])
                ){
                if (
                    is_array($data = $miAPI->editar_concepto(
                        $decoded['id_Concepto'], 
                        $decoded['motivo'], 
                        $decoded['ubicacion_predio'], 
                        $decoded['localidad'], 
                        $decoded['adquiriente'], 
                        $decoded['ubicacion'], 
                        $decoded['domicilio_notificar'], 
                        $decoded['localidad_notificar'], 
                        $decoded['no_cuenta'], 
                        $decoded['enajenante'], 
                        $decoded['fecha'], 
                        $decoded['id_Avaluo']))) {
                    $message = $data;
                }else {
                    $message["message"] = "Error al intentar actualizar el concepto.";
                }  
            }else{
                $message["message"] = "Error, Faltan datos";
            }
            break;
        case "eliminar_concepto":
            if(isset($decoded['id_Concepto'])){
                if (is_array($data = $miAPI->eliminar_concepto($decoded['id_Concepto']))) {
                    $message = $data;
                } else {
                    $message["message"] = "Error al intentar eliminar ese concepto.";
                }  
            }else{
                $message["message"] = "Error, Faltan datos";
            }
            break;

        default:
            $message["message"] = "Acción NO válida";
            break;
    }

    //Codificar a JSON y mostrarlo en pantalla
    header('Content-type: application/json; charset=utf-8');
    $miJSON = json_encode($message, JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);
    print $miJSON;