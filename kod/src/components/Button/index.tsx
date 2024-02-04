import React from 'react'
import './button.scss'
interface ButtonProps{
    text:string
    onClick:()=>void
}

export default function Button({text,onClick}:ButtonProps) {
  return (
    <button className='buttons' onClick = {onClick}>{text}</button>

  )
}
