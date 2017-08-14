<?php

class Consultas{
    private $conexion;
    private $results;
    private $mysqli;
    
    public function __construct() {
        $this->conexion = new Conexion();
        $this->mysqli = $this->conexion->mysqli;
    }

    /*
    *
    *Clientes
    *Este conjunto de funciones sirve para
    *COnsultar los clientes
    *
    */

    public function consultar_clientes(){
        $query = "SELECT * FROM cliente;";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
    public function consultar_clientes_por_id($id_Cliente)
    {
        $query = "SELECT * FROM cliente WHERE id_Cliente = $id_Cliente;";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
    public function consultar_avaluos_por_id($id_Avaluo)
    {
        $query = "SELECT * FROM avaluos WHERE id_Avaluo = $id_Avaluo;";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
    public function consultar_conceptos_por_id($id_Concepto)
    {
        $query = "SELECT * FROM concepto WHERE id_Concepto = $id_Concepto;";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
    public function agregar_cliente($RFC, $nombre, $apellido, $colonia, $municipio, $tenencia, $reg, $manzana, $lote, $cPostal, $telefono, $celular)
    {
        
        $query = $query = "SELECT * FROM cliente where RFC like '$RFC'";
        $res = $this->mysqli->query($query);

        if($res->num_rows > 0){
            $this->results = array("Ya existe ese dato");;
            return $this->results;
        }else{
            $query = "INSERT INTO `cliente` (`id_Cliente`, `RFC`, `Apellido`, `Nombre`, `Colonia`, `Municipio`, `Tenencia`, `reg`, `manzana`, `lote`, `cPostal`, `Telefono`, `Celular`) VALUES (NULL, '$RFC',  '$apellido', '$nombre', '$colonia', '$municipio', '$tenencia', '$reg', '$manzana', '$lote', '$cPostal', '$telefono', '$celular');";
            $res = $this->mysqli->query($query);
            $this->results = array("dato insertado correctamente");
            return $this->results;
        } 
    }
    public function editar_cliente($idCliente, $RFC, $nombre, $apellido, $colonia, $municipio, $tenencia, $reg, $manzana, $lote, $cPostal, $telefono, $celular)
    {
        $query = "SELECT * FROM cliente WHERE id_Cliente = $idCliente;";
        $res = $this->mysqli->query($query);
        if($res->num_rows == 0){
            $this->results = array("No existe ese dato");;
            return $this->results;
        }else{
            $query = "UPDATE `cliente` SET `RFC` = '$RFC', `Apellido` = '$apellido', `Nombre` = '$nombre', `Colonia` = '$colonia', `Municipio` = '$municipio', `Tenencia` = '$tenencia', `reg` = '$reg', `manzana` = '$manzana', `lote` = '$lote', `cPostal` = '$cPostal', `Telefono` = '$telefono', `Celular` = '$celular' WHERE `cliente`.`id_Cliente` = $idCliente;";
            $res = $this->mysqli->query($query);
            $this->results = array("dato actualizado correctamente");
            return $this->results;
        }
    }
    public function eliminar_cliente($idCliente){
        $query = "SELECT * FROM cliente where id_Cliente = '$idCliente'";
        $res = $this->mysqli->query($query);

        if($res->num_rows == 0){
            $this->results = array("No existe ese dato");;
            return $this->results;
        }else{
            $query = "DELETE FROM cliente WHERE id_Cliente = $idCliente;";
            $res = $this->mysqli->query($query);
            $this->results = array("dato eliminado correctamente");
            return $this->results;
        } 
    }
    /*
    *
    *Avaluos
    *Este conjunto de funciones sirve para
    *COnsultar los avaluos
    *
    */
    public function consultar_avaluos(){
        $query = "SELECT * FROM avaluos ";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
    public function agregar_avaluo($tipo, $pagoCatastro, $fecha, $cto_Avaluo, $subtotal, $total, $id_Cliente)
    {
        $query = $query = "INSERT INTO `avaluos` (`id_Avaluo`, `Tipo`, `PagoCatastro`, `Fecha`, `cto_Avaluo`, `Subtotal`, `Total`, `id_Cliente`) VALUES (NULL, '$tipo', '$pagoCatastro', '$fecha', '$cto_Avaluo', '$subtotal', '$total', '$id_Cliente');";

        $res = $this->mysqli->query($query);
        $this->results = array("dato insertado correctamente");
        return $this->results;
    } 
    public function editar_avaluo($tipo, $pagoCatastro, $fecha, $cto_Avaluo, $subtotal, $total, $id_Cliente, $id_Avaluo)
    {
        $query = "SELECT * FROM avaluos WHERE id_Avaluo = $id_Avaluo;";
        $res = $this->mysqli->query($query);
        if($res->num_rows == 0){
            $this->results = array("No existe ese dato");;
            return $this->results;
        }else{
            $query = "UPDATE `avaluos` SET `Tipo` = '$tipo', `PagoCatastro` = '$pagoCatastro', `Fecha` = '$fecha', `cto_Avaluo` = '$cto_Avaluo', `Subtotal` = '$subtotal', `Total` = '$total', `id_Cliente` = '$id_Cliente' WHERE `avaluos`.`id_Avaluo` = $id_Avaluo;";
            $res = $this->mysqli->query($query);
            $this->results = array("dato actualizado correctamente");
            return $this->results;
        }
    }
    public function eliminar_avaluo($idAvaluo){
        $query = "SELECT * FROM avaluos where id_Avaluo = '$idAvaluo'";
        $res = $this->mysqli->query($query);

        if($res->num_rows == 0){
            $this->results = array("No existe ese dato");;
            return $this->results;
        }else{
            $query = "DELETE FROM avaluos WHERE id_Avaluo = $idAvaluo;";
            $res = $this->mysqli->query($query);
            $this->results = array("dato eliminado correctamente");
            return $this->results;
        } 
    }

    /*
    *
    *Conceptos
    *Este conjunto de funciones sirve para
    *COnsultar los Conceptos
    *
    */

    public function consultar_conceptos(){
        $query = "SELECT * FROM concepto ";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
    public function agregar_concepto($motivo, $ubicacion_predio, $localidad, $adquiriente, $ubicacion, $domicilio_notificar, $localidad_notificar, $no_cuenta, $enajenante, $fecha, $id_Avaluo)
    {
        
        $query = $query = "SELECT * FROM concepto where id_Avaluo = '$id_Avaluo'";
        $res = $this->mysqli->query($query);

        if($res->num_rows > 0){
            $this->results = array("Ya hay un concepto para ese avaluo");;
            return $this->results;
        }else{
            $query = "INSERT INTO `concepto` (`id_Concepto`, `Motivo`, `UbicacionPredio`, `Localidad`, `Adquiriente`, `Ubicacion`, `DomNotificar`, `LocalidadNotificar`, `No_Cuenta`, `Enajenante`, `Fecha`, `id_Avaluo`) VALUES (NULL, '$motivo', '$ubicacion_predio', '$localidad', '$adquiriente', '$ubicacion', '$domicilio_notificar', '$localidad_notificar', '$no_cuenta', '$enajenante', '$fecha', '$id_Avaluo');";
            $res = $this->mysqli->query($query);
            $this->results = array("dato insertado correctamente");
            return $this->results;
        } 
    }
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
    {
        $query = "SELECT * FROM concepto WHERE id_Concepto = $idConcepto;";
        $res = $this->mysqli->query($query);
        //Comprobar si existe el dato
        if($res->num_rows == 0){
            $this->results = array("No existe ese dato");;
            return $this->results;
        }else{
            //Una vez que se comprobo, si el id de ese avaluo a editar está en otra tupla distinta a la del id que se va a editar, se hace un intercambio
            $query = "UPDATE `concepto` SET `Motivo` = '$motivo', `UbicacionPredio` = '$ubicacion_predio', `Localidad` = '$localidad', `Adquiriente` = '$adquiriente', `Ubicacion` = '$ubicacion', `DomNotificar` = '$domicilio_notificar', `LocalidadNotificar` = '$localidad_notificar', `No_Cuenta` = '$no_cuenta', `Enajenante` = '$enajenante', `Fecha` = '$fecha', `id_Avaluo` = '$id_Avaluo' WHERE `concepto`.`id_Concepto` = $idConcepto;";
            $res = $this->mysqli->query($query);
            $this->results = array("dato actualizado correctamente");
            return $this->results;
        }
    }
    public function eliminar_Concepto($idConcepto){
        $query = "SELECT * FROM concepto where id_Concepto = '$idConcepto'";
        $res = $this->mysqli->query($query);

        if($res->num_rows == 0){
            $this->results = array("No existe ese dato");;
            return $this->results;
        }else{
            $query = "DELETE FROM concepto WHERE id_Concepto = $idConcepto;";
            $res = $this->mysqli->query($query);
            $this->results = array("dato eliminado correctamente");
            return $this->results;
        } 
    }
}
