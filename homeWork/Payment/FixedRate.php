<?php

require 'Payment/PaymentTrait.php';

class FixedRate implements PaymentTypeInterface
{
    use PaymentTrait;
}