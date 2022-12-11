(defrule course-finder
    (course (institution ?institution) (category ?categoryDB) (budget ?budgetDB) (regime ?regimeDB))
    (category ?category)
    (budget ?budget)
    (regime ?regime)
    (test (eq ?categoryDB ?category))
    (test (eq ?budgetDB ?budget))
    (test (eq ?regimeDB ?regime))
    =>
    (assert (result (institution ?institution))))