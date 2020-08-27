<?php


interface ITypePayment
{
    public function getPayment() : float;
    public function setPayment(float $amountOfPayment) : void;
}