<?php


interface ProjectInterface
{
    public function addEmployee(Employee $employee) : void;

    public function getListEmployees() : array;

    public function deleteEmployee(Employee $employee) : bool;

    public function getTotalCostOfProject() : float;
}