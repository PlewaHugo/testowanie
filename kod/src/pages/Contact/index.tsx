import Container from "@/components/Container";
import Heading from "@/components/Heading";
import './contact.scss'
import { FormEvent, useState } from "react";
import Paragraph from "@/components/Paragraph";
export default function Contact() {

  const [name,setName]=useState('')
  const [email,setEmail]=useState('')
  const [topic,setTopic]=useState('')
  const [message,setMessage]=useState('')
  const [isSubmitedForm,setIsSubmitedForm]=useState(false)
  const submitForm = (e:FormEvent<HTMLFormElement>)=>{
    console.log(name,email,topic,message)
    setIsSubmitedForm(true)
    e.preventDefault()
  }

  return <Container>
            <Heading level={1} content="Skontaktuj się z nami"/>
            {!isSubmitedForm?(
              <form onSubmit = {submitForm}  className="formularz">
                <input value={name} onChange={(e)=>setName(e.target.value)} type="text" className="formularz__input" placeholder="Podaj imię:"/>
                <input value={email} onChange={(e)=>setEmail(e.target.value)}  type="email" className="formularz__input" placeholder="Podaj e-mail"/>
                <input value={topic} onChange={(e)=>setTopic(e.target.value)}  type="text" className="formularz__input" placeholder="Podaj temat"/>
                <textarea value={message} onChange={(e)=>setMessage(e.target.value)} className="formularz__textarea" placeholder="treść wiadomości"></textarea>
                <input type="submit" className="formularz__button" value="Wyślij wiadomość"/>
              </form>
            ):(<Paragraph content="Dziękujemy za wysłanie wiadomości" />)}
            
  </Container>;
}