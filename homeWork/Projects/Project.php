<?php



class Project implements ProjectInterface
{
    private array $arrayEmployees = array();
    private float $totalCost = 0;

    public function addEmployee(Employee $employee) : void
    {
        array_push($this->arrayEmployees, $employee);
    }

    public function getListEmployees() : array
    {
        return $this->arrayEmployees;
    }

    public function deleteEmployee(Employee $employee) : bool
    {
        if(($key = array_search($employee, $this->arrayEmployees)) !== FALSE)
        {
            unset($this->arrayEmployees[$key]);
            return true;
        }

        return false;
    }

    public function getTotalCostOfProject() : float
    {
        foreach ($this->arrayEmployees as $value)
        {
            $this->totalCost += $value->getSalary();
        }

        return $this->totalCost;
    }

}