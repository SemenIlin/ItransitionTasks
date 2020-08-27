<?php


trait EmployeeTrait
{
    private ITypePayment $typePayment;

    public function  __construct(ITypePayment $payment, string $firstName, string $lastName, string $patronymic)
    {
        parent::__construct($firstName, $lastName, $patronymic);
        $this->typePayment = $payment;
    }

    public function getSalary() : float
    {
        return $this->typePayment->getPayment();
    }
}