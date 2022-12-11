(deftemplate course
    (slot id)
    (slot institution)
    (slot category)
    (slot budget)
    (slot regime)
    )

(deftemplate result
    (slot id)
    (slot institution)
    )

(deffacts courses
    (course
        (id 0)
        (institution STEP-IT)
        (category programming)
        (budget high)
        (regime offline)
        )
    
    (course
        (id 1)
        (institution IT-ACADEMY)
        (category programming)
        (budget low)
        (regime online)
        )
    
    (course
        (id 2)
        (institution SAT-ACADEMY)
        (category business)
        (budget mid)
        (regime hybrid)
        )
    
    (course
        (id 3)
        (institution THINK-WISE)
        (category business)
        (budget low)
        (regime online)
        )

    (course
        (id 4)
        (institution LLBS)
        (category language)
        (budget low)
        (regime offline)
        )
    (course
        (id 5)
        (institution CELT-COLLEGES)
        (category language)
        (budget low)
        (regime offline)
        )
    )