Imports System.Web.Mvc
Imports System.Linq
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin

Namespace Controllers
    Public Class QuestionController
        Inherits Controller

        'COMMENT
        ' GET: Question
        Function Main() As ActionResult
            Return View()
        End Function

        ' GET: Question/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: Question/Create
        Function AddTraits() As ActionResult
            Dim db As New ApplicationDbContext
            ViewData("TraitId") = New SelectList(db.Traits, "traitId", "trait")
            Return PartialView("AddTraits")
        End Function

        ' POST: Question/Create
        <HttpPost()>
        Function AddTraits(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here
                Dim db = New ApplicationDbContext
                Dim trait = New Traits With {
                    .trait = collection.GetValue("trait").AttemptedValue,
                    .description = collection.GetValue("description").AttemptedValue
                }
                db.Traits.Add(trait)
                db.SaveChanges()

                Return RedirectToAction("ViewTraits")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Question/Edit/5
        Function EditTraits(ByVal id As Integer) As ActionResult
            Dim db = New ApplicationDbContext
            Dim trait = db.Traits.Where(Function(model) model.traitId = id).First

            Return View(trait)
        End Function

        ' POST: Question/Edit/5
        <HttpPost()>
        Function EditTraits(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here
                Dim db = New ApplicationDbContext
                Dim trait = db.Traits.Where(Function(model) model.traitId = id).First

                trait.trait = collection.GetValue("trait").AttemptedValue
                trait.description = collection.GetValue("description").AttemptedValue

                db.Entry(trait).State = Entity.EntityState.Modified
                db.SaveChanges()

                Return RedirectToAction("ViewTraits")
            Catch ex As Exception
                'MsgBox(ex.Message)
                Return View()
            End Try
        End Function

        ' GET: Question/Delete/5
        Function DeleteTrait(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Question/Delete/5
        <HttpPost()>
        Function DeleteTrait(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here
                Dim db = New ApplicationDbContext
                Dim trait = db.Traits.Where(Function(model) model.traitId = id).First

                db.Questions.RemoveRange(db.Questions.Where(Function(x) x.traitId = trait.traitId))

                db.Traits.Remove(trait)
                db.SaveChanges()

                Return RedirectToAction("ViewTraits")
            Catch
                Return View()
            End Try
        End Function

        Function ViewTraits() As ActionResult
            Dim db = New ApplicationDbContext
            Dim model = db.Traits

            Return View(model)
        End Function

        Function TakeSurvey() As ActionResult
            Dim db = New ApplicationDbContext
            Dim questions = db.Questions
            Return View(questions)
        End Function

        <HttpPost>
        Function TakeSurvey(checkBoxes As FormCollection) As ActionResult
            Dim db = New ApplicationDbContext
            Dim questions = db.Questions

            Dim traits = db.Traits

            Dim ratings = db.Ratings.ToList().Where(Function(x) x.userId = User.Identity.GetUserId)

            Dim db1 = New ApplicationDbContext
            If ratings.Count() <= 0 Then
                For Each trait In traits
                    Dim rate As New Ratings With {
                  .userId = User.Identity.GetUserId,
                  .traitId = trait.traitId,
                  .score = 0}

                    db1.Ratings.Add(rate)
                    db1.SaveChanges()
                Next
            End If

            Dim rating As New List(Of KeyValuePair(Of String, Integer))


            For Each item In checkBoxes.AllKeys
                Dim trt = checkBoxes.GetValue(item).AttemptedValue.Split(" ")
                If rating.Exists(Function(x) x.Key = trt(1)) Then
                    Dim oldRate = rating.Where(Function(x) x.Key = trt(1)).First
                    Dim newRate = New KeyValuePair(Of String, Integer)(oldRate.Key, oldRate.Value + Convert.ToInt64(trt(0)))
                    rating.Remove(oldRate)
                    rating.Add(newRate)
                Else
                    rating.Add(New KeyValuePair(Of String, Integer)(trt(1), Convert.ToInt64(trt(0))))
                End If
            Next

            For Each rt In rating
                Dim qCount = questions.Where(Function(x) x.traitId = rt.Key).Count
                Dim newScore = (rt.Value / (qCount * 5)) * 100
                Dim userId = User.Identity.GetUserId

                Dim oldRating = db1.Ratings.Where(Function(x) x.userId = userId).Where(Function(x) x.traitId = rt.Key).First
                oldRating.score = newScore

                db1.Entry(oldRating).State = Entity.EntityState.Modified
                db1.SaveChanges()
            Next

            ViewBag.message = "Your profile has been updated!"

            Return View(questions)
        End Function

        'VIEW QUESTIONS
        Function ViewQuestions() As ActionResult
            Dim db = New ApplicationDbContext
            Dim model = db.Questions

            Return View(model)
        End Function

        ' GET: Question/Create
        Function AddQuestions() As ActionResult
            Return PartialView("AddQuestions")
        End Function

        ' POST: Question/Create
        <HttpPost()>
        Function AddQuestions(ByVal collection As FormCollection) As ActionResult
            Try
                Dim isNegative As Boolean = False
                If collection.GetValue("isNegative").AttemptedValue.Contains("true") Then
                    isNegative = True
                End If

                ' TODO: Add insert logic here
                Dim db = New ApplicationDbContext
                Dim q = New Questions With {
                    .question = collection.GetValue("question").AttemptedValue,
                    .isNegative = isNegative,
                    .traitId = collection.GetValue("traitsList").AttemptedValue
                }
                db.Questions.Add(q)
                db.SaveChanges()

                Return RedirectToAction("ViewQuestions")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Question/Edit/5
        Function EditQuestions(ByVal id As Integer) As ActionResult
            Dim db = New ApplicationDbContext
            Dim q = db.Questions.Where(Function(model) model.questionId = id).First

            Return View(q)
        End Function

        ' POST: Question/Edit/5
        <HttpPost()>
        Function EditQuestions(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                Dim isNegative As Boolean = False
                If collection.GetValue("isNegative").AttemptedValue.Contains("true") Then
                    isNegative = True
                End If

                ' TODO: Add update logic here
                Dim db = New ApplicationDbContext
                Dim q = db.Questions.Where(Function(model) model.questionId = id).First

                q.question = collection.GetValue("question").AttemptedValue
                q.isNegative = isNegative
                q.traitId = collection.GetValue("traitsList").AttemptedValue

                db.Entry(q).State = Entity.EntityState.Modified
                db.SaveChanges()

                Return RedirectToAction("ViewQuestions")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Question/Delete/5
        Function DeleteQuestion(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Question/Delete/5
        <HttpPost()>
        Function DeleteQuestion(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here
                Dim db = New ApplicationDbContext
                Dim q = db.Questions.Where(Function(model) model.questionId = id).First
                db.Questions.Remove(q)
                db.SaveChanges()

                Return RedirectToAction("ViewQuestions")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace