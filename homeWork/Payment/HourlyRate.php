<?php


class HourlyRate implements PaymentTypeInterface
{
    private float $amountOfPayment;
    private float $quantityHours;

    public function __construct(float $amountOfPayment, float $quantityHours)
    {
        $this->amountOfPayment = $amountOfPayment;
        $this->quantityHours = $quantityHours;
    }

    public function getPayment() : float
    {
        return  $this->amountOfPayment * $this->quantityHours;
    }
    public function setPayment(float $amountOfPayment) : void
    {
        $this->amountOfPayment = $amountOfPayment;
    }
    public function setQuantityHours(float $quantityHours) : void
    {
        $this->quantityHours = $quantityHours;
    }

}